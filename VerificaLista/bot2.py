# coding=utf-8
from iqoptionapi.stable_api import IQ_Option
import time, json, sys
from datetime import datetime
from colorama import Fore, init


def get_CandleResults(lista):
 returnedList = []
 init(autoreset=True)
 API = IQ_Option('marcelobertinatto@hotmail.com', 'Fh006131__')
 check, reason=API.connect()
 API.change_balance('PRACTICE')
 print('QUE LOCURA')

    #if API.check_connect() == False:
    #    print('Erro ao se conectar')
    #else:
    #    for l in lista:
    #        l = l.split(',') 
    #        horario = datetime.strptime(l[0] + ":00", "%Y-%m-%dT%H:%M:%S")
    #        horario = datetime.timestamp(horario)
    #        if l[3] == "M5":
    #            velas = API.get_candles(l[1],300,3,int(horario))
    #        elif l[3] == "M15":
    #            velas = API.get_candles(l[1],900,3,int(horario))
    #        else:
    #            print ('Dado não lido. Incompatível!')    

    #        for v in range(len(velas)):
    #            if int(velas[v]['from']) == int(horario):
    #                dir = 'call' if velas[v]['open'] < velas[v]['close'] else 'put' if velas[v]['open'] > velas[v]['close'] else 'doji'
    #                if dir == l[2].lower():
    #                    returnedList.append(l[0]+','+l[1]+','+l[2]+','+l[3]+'-✅')
    #                    print(l[0],l[1],l[2],l[3],'|', Fore.GREEN + 'WIN')
    #                else:
    #                    if int(velas[v]['from']) == int(horario):
    #                        dir = 'call' if velas[v]['open'] < velas[v]['close'] else 'put' if velas[v]['open'] > velas[v]['close'] else 'doji'
    #                        if dir == l[2].lower():
    #                            returnedList.append(l[0]+','+l[1]+','+l[2]+','+l[3]+'-✅1️')
    #                            print(l[0],l[1],l[2],l[3],'|', Fore.GREEN + 'WIN')
    #                        else:
    #                            if int(velas[v]['from']) == int(horario):
    #                                dir = 'call' if velas[v]['open'] < velas[v]['close'] else 'put' if velas[v]['open'] > velas[v]['close'] else 'doji'
    #                                if dir == l[2].lower():
    #                                    returnedList.append(l[0]+','+l[1]+','+l[2]+','+l[3]+'-✅2️')
    #                                    print(l[0],l[1],l[2],l[3],'|', Fore.GREEN + 'WIN')
    #                                else:
    #                                    returnedList.append(l[0]+','+l[1]+','+l[2]+','+l[3]+'-❌')
    #                                    print(l[0],l[1],l[2],l[3],'|', Fore.RED + 'LOSS')                           
                

#lista = ['2021-04-02T10:00,USDJPY,CALL,M5','2021-04-02T11:00,USDJPY,CALL,M5',
#'2021-04-02T11:20,USDJPY,PUT,M5','2021-04-02T09:00,USDJPY,PUT,M15']

#resultado = get_CandleResults(lista)

capturedList = sys.argv[1]
get_CandleResults(capturedList)