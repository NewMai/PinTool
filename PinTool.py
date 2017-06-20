

import sys
import logging
import os


class CAddr:

	def __init__(self):
		self.codeStartAddress = 0
		self.codeEndAddress = 0

	def GetStartAndEndAddress(self, filename):
		with open(filename, "r") as f:
			try:
				line = f.readline()  # Read codeStartAddress 
				i = line.find("=")
				var = line[i+1:-1]
				self.codeStartAddress = int(var, 16)		
				line = f.readline()  # Read codeEndAddress
				i = line.find("=")
				var = line[i+1:-1]
				self.codeEndAddress = int(var, 16)
		
			except Exception as ex:
				print("Error: " + str(ex))
				print("Can not get code start address and code end address.")
				print("You may lost your \"%s\" file"%filename)
				
		pass
	
	pass
	
g_Address = CAddr()

logging.basicConfig(level = logging.WARNING,
					filename = "./log.log",
					filemode = 'w',
					#format = "%(asctime)s - %(filename)s[line:%(lineno)d] - %(levelname)s: %(message)s")
					format = "%(asctime)s - %(levelname)s: %(message)s")

def ReadOneBlock(f):
	"""
	读取一块代码块进来
	"""
	var = []
	cnt = 1

	for line in f:
		if "----Trace" in line and cnt == 1:
			continue
		cnt += 1
		line = line[:-1]
		if "----" != line:
			var.append(line)
		else:
			break
	return var		

def ReadBlocks(fileName):
	"""
	读取所有的代码块进来保存到字典中，
	最后返回这个字典
	"""
	with open(fileName, "r") as f:
		data_dict = dict([])
		
		var = ReadOneBlock(f)
		while [] != var:
			key = str(var[0])[:8]
			data_dict[key] = var
			var = ReadOneBlock(f)
		return data_dict
	pass
	
def ValifiedAddress(line):
	"""
	验证call 后面的地址是否在 我们的地址空间上
	即  codeStartAddress =< addr <= codeEndAddress
	"""
	res = False
	
	try:
		i = line.find("call");
		if i > 0:
			var = line[i+ 5:]
			var = int(var, 16)
			if var >= g_Address.codeStartAddress \
				and var <= g_Address.codeEndAddress:
				res = True
	except:
		# 出现目标地址是寄存器或者是其它的情况
		#logging.error("验证地址时，解析地址错误： %s"%"ValifiedAddress")
		pass
	
	return res
	pass
	
def CheckBlock(block):
	"""
	检查这个代码块的最后是否是
	一条 return 语句，或者是一条 call 语句
	"""
	
	length = len(block)
	if length == 0:
		return 0
	var = str(block[length-1])
	if "ret" in var:
		return 1
	if "call" in var and True == ValifiedAddress(var):
		return 2
	return 0

def ParseStack(stack):
	var = ""
	for ele in stack:
		var +=  ele + "->"
	return var
		
def MyDebug(line, block):
	var = "Appending Address: %s\n"%line[:8]
	var += str(line)
	var += str(block)
	logging.info(var)
	pass
		
def Core(bblInst, bblTracing, bblResult):
	
	stack = ["0",]
	f = open(bblTracing, "r")
	f3 = open(bblResult, "w")
	
	# 读取 所有的代码块
	data_dict = ReadBlocks(bblInst)
	
	cnt = 1
	e_cnt = 0
	lastLen = 0
	for line in f:
		e_cnt += 1
		logging.info("Dealing line : %d"%e_cnt)
		data1 = line[:-1]
		if line == "" or line == "\n":
			break
		Addr = str(line[:8])
		
		try:
			data2 = data_dict[Addr]
		except Exception as exp:
			xxx = "{0} 中的地址 0x{1} 没有在 {2} 中出现过"
			#print(xxx.format(bblTracing, Addr, bblInst))
			logging.warning(xxx.format(bblTracing, Addr, bblInst))
			continue
		
		prefix = "[{0}] ".format(len(stack))
		temp = data1 + " - " + prefix
		if lastLen == len(stack):  # 堆栈与上次的没有变
			temp += "..."
		else:
			temp += ParseStack(stack)
		f3.write(temp + "\n")
		lastLen = len(stack)
		
		res = CheckBlock(data2)
		if 1 == res:  # ret
			if len(stack) > 0:  # 这里有待考察
				stack.pop()
			else:
				#print("【%d】 @@@栈已空，但是还在请求出栈@@@"%cnt)
				xxx = "【%d】 @@@栈已空，但是还在请求出栈@@@"%cnt
				logging.error(xxx)
				cnt += 1
		elif 2 == res:   # call
			stack.append(Addr)
			MyDebug(data1, data2)
	f.close()
	f3.close()
	pass

def Main():

	bblResult = "bblResult.log"
	test = len(sys.argv)	
	if test == 1:
		bblInst = "1.txt"
		bblTracing = "2.txt"
		Core(bblInst, bblTracing, bblResult)
	elif test == 2:
		selfName = os.path.basename(__file__)
		var = "\nUsage:\n" + \
			  "%s [bblInst.log] [bblTracing.log]\n"%selfName
		print(var)
	else:
		bblInst = sys.argv[1]
		bblTracing = sys.argv[2]
		g_Address.GetStartAndEndAddress("kscope.cfg")
		Core(bblInst, bblTracing, bblResult)
	pass

Main()


