print('\t Tabuada Abaixo ')
numero = int(input("Digite o numero o qual queira saber a tabuada: "))

print('\n'f'Tabuada de {numero}:''\n')

for v_taboada in range(1, 11):

    print(f'{numero} X {v_taboada} = {numero*v_taboada}')
