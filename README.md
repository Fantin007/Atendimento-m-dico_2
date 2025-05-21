# 🏥 Simulação de Atendimento Médico com Estrutura de Dados

Este projeto simula o atendimento de pacientes em um consultório médico, organizando-os em filas com diferentes níveis de prioridade (Alta, Média e Baixa). A simulação é feita via console, utilizando filas (`Queue<T>`) para gerenciar os atendimentos com base na prioridade.

Desenvolvido em **C#** como parte da APS de Estrutura de Dados para o curso de Engenharia de Software.

---

## 📌 Funcionalidades

- Adicionar paciente com nível de prioridade (Alta, Média ou Baixa)
- Atender pacientes por ordem de prioridade (Alta > Média > Baixa)
- Listar todos os pacientes organizados por prioridade
- Exibição colorida para facilitar visualização no terminal

---

## 🎨 Cores por Prioridade

| Prioridade | Cor do Console |
|------------|----------------|
| Alta       | Vermelho       |
| Média      | Amarelo        |
| Baixa      | Verde          |



## 💻 Pré-requisitos

- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/)
- Visual Studio 2022+ ou outro editor compatível

---

## Exemplos de Uso

```
=== SIMULAÇÃO DE ATENDIMENTO MÉDICO ===
1. Adicionar paciente
2. Atender próximo paciente
3. Listar pacientes na fila
0. Sair
```

Exemplo de inserção:
```
Nome do paciente: João
Prioridade do paciente:
1 - Alta
2 - Média
3 - Baixa
Escolha (1-3): 1
Paciente João com prioridade Alta adicionado.
```

---

## Estrutura de Dados Utilizada

- `Queue<T>` para implementar as filas separadas por prioridade
- `Enum` para definir os níveis de prioridade
- `ConsoleColor` para destacar visualmente os pacientes por prioridade


