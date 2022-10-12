from vendas import calc_precos
import vendas.formata.preco

preco = 49.90
preco_aumento = calc_precos.aumento(preco,15, formata=True)
print(preco_aumento)

preco_reducao = calc_precos.reducao(preco,15, formata=True)
print(preco_reducao)

print(vendas.formata.preco.real(50))