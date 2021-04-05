# coding=utf-8
import time, json
from datetime import datetime
from colorama import Fore, init
import sys

def get_CandleResults(lista):
    print('Hello')
    print(lista)
    aaa = lista.split(',')
    print("lista quebrada")
    print (aaa)
    #for l in lista:
        #l = l.split(',')
        #print(l)


capturedList = sys.argv[1]
get_CandleResults(capturedList)
    
