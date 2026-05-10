# RachaAí Blazor

Aplicação desenvolvida em Blazor para a disciplina de Interação Humano-Computador e UX, com o objetivo de transformar o wireframe criado no Miro em uma interface funcional em C#/.NET.

## Integrantes

- Kaio Moreira
- Icaro ferreira

## Problema Focado

O aplicativo RachaAí foi projetado para ajudar grupos de pessoas a dividir despesas coletivas, como contas de república, churrascos, viagens e eventos. A principal dor priorizada foi permitir que o usuário visualize rapidamente quanto tem a receber, quanto precisa pagar e qual é o seu saldo geral.

## Justificativa de Design

A interface foi organizada com base em princípios de IHC e UX:

- Hierarquia Visual: os três cards no topo destacam as informações financeiras mais importantes.
- Visibilidade do Status do Sistema: cores verdes indicam valores a receber e cores vermelhas indicam valores a pagar.
- Consistência: utilização do Bootstrap para manter padrão visual em cards, badges e botões.
- Affordance: o botão "Adicionar Novo Gasto" possui aparência clara de elemento clicável.
- Componentização: cada grupo é exibido por meio do componente reutilizável `GrupoCard.razor`.

## Fluxo do Usuário

1. O usuário acessa o dashboard.
2. Visualiza os valores de Total a Receber, Total a Pagar e Saldo Geral.
3. Consulta a lista de grupos ativos.
4. Identifica rapidamente se está no vermelho ou no azul por meio das cores.
5. Clica no botão "Adicionar Novo Gasto" para registrar uma nova despesa.

## Implementação Blazor

O protótipo criado no Miro foi convertido em componentes no Blazor da seguinte forma:

- `Models/Grupo.cs`: define a estrutura de dados dos grupos.
- `Shared/GrupoCard.razor`: componente reutilizável para exibir cada grupo.
- `Pages/Dashboard.razor`: página principal com cards de resumo, listagem de grupos e botão de ação.

A página utiliza o sistema de Grid do Bootstrap (`row` e `col`) para garantir responsividade.

## Dificuldade Técnica

O principal desafio foi componentizar o `GrupoCard`, permitindo que o componente recebesse um objeto `Grupo` como parâmetro e aplicasse estilos diferentes de acordo com a propriedade `NoVermelho`.

## Tecnologias Utilizadas

- C#
- .NET
- Blazor
- Bootstrap
- GitHub

## Repositório

Nome do repositório:

`ihcux-racha-ai-blazor`
