# Sistema de Gestão de Funcionários

## Descrição

Nesta semana, revisei os conceitos de Programação Orientada a Objetos pelo curso de C# Essencial do Macoratti. Após a revisão, pedi ao ChatGPT um desafio que envolvesse o uso de Herança e Polimorfismo. O desafio proposto é o desenvolvimento de um sistema de gestão de funcionários para uma empresa.

## Desafio

Você foi contratado para desenvolver um sistema de gestão de funcionários para uma empresa. O sistema deve ser capaz de gerenciar diferentes tipos de funcionários e suas respectivas funções.

### Requisitos

#### Classe Base: `Funcionario`

- **Propriedades**:
  - `Nome` (string)
  - `SalarioBase` (decimal)

- **Métodos**:
  - `CalcularSalario()` - Retorna o salário base.
  - `ExibirDados()` - Exibe o nome e o salário base.

#### Classes Derivadas:

1. **FuncionarioHorista**

   - **Propriedades**:
     - `HorasTrabalhadas` (int)
     - `ValorPorHora` (decimal)

   - **Métodos**:
     - Sobrescrever `CalcularSalario()` para retornar o produto das horas trabalhadas pelo valor por hora.
     - Construtor que inicializa as propriedades.

2. **FuncionarioComissionado**

   - **Propriedades**:
     - `VendasRealizadas` (decimal)
     - `PercentualComissao` (decimal)

   - **Métodos**:
     - Sobrescrever `CalcularSalario()` para retornar o salário base mais o valor das comissões (vendas realizadas * percentual de comissão).
     - Construtor que inicializa as propriedades.

3. **FuncionarioGerente**

   - **Propriedades**:
     - `Bonus` (decimal)

   - **Métodos**:
     - Sobrescrever `CalcularSalario()` para retornar o salário base mais o bônus.
     - Construtor que inicializa as propriedades.

#### Classe `Program`

- Crie uma lista de funcionários com diferentes tipos (Horista, Comissionado, Gerente).
- Para cada funcionário, exiba os dados e o salário calculado usando o método `ExibirDados()`.

## Objetivo

- Demonstrar o uso de herança e polimorfismo.
- Praticar a sobrescrita de métodos para fornecer implementações específicas em classes derivadas.


![Captura de tela 2024-08-16 225115](https://github.com/user-attachments/assets/2d7d21f9-9606-4a07-a14e-67183cfae43f)
