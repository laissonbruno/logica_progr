import random

def embaralha(nome):
    a = list(nome)
    random.shuffle(a)
    a = ''.join(a)
    print(a.lower())

while True:
    nome = input('Digite algo: ')
    embaralha(nome)