import json

f = open('dados.json')

Dados = json.load(f)

Dados = [x for x in Dados if x['valor'] > 0]

menor = float("inf")

#menor faturamento diário
for x in Dados:
  atual = x['valor']
  if(menor > atual):
    menor = atual
print('O menor valor de faturamento ocorrido em um dia do mês foi de ', menor)

#maior faturamento diário
maior = 0.0

for x in Dados:
  atual = x['valor']
  if(maior < atual):
    maior = atual
print('O maior valor de faturamento ocorrido em um dia do mês foi de ', maior)


#faturamento diário superior à média mensal

totalValor = 0.0

for x in Dados:
  atual = x['valor']
  totalValor = totalValor + float(atual)
  
media = totalValor/30

dias = 0

for x in Dados:
  atual = x['valor']
  if(atual > media):
    dias = dias + 1

print('O número de dias no mês em que o valor do faturamento diário superou à média mensal foi de ', dias)

f.close()