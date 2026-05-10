# ihcux-racha-ai-blazor

Repositório dedicado à Atividade Prática: Do Wireframe ao Código com Blazor, desenvolvida para a disciplina de Interação Humano Computador e UX do Centro Universitário UNA.

## 📌 Sobre o Projeto
Este projeto consiste na implementação de uma nova página estática em Blazor que representa o Dashboard Principal do aplicativo de finanças coletivas **RachaAí**. O foco principal da atividade foi aplicar conceitos de **Hierarquia Visual** e **Componentização**, garantindo a heurística de "Visibilidade do Status do Sistema".

## 💡 Respostas da Atividade

### Implementação Blazor
**Como a hierarquia visual do Miro foi transposta para os componentes Blazor?**
A transposição foi realizada utilizando o sistema de Grid do Bootstrap (`row` e `col`) para estruturar a página de forma responsiva. Os elementos de maior importância da interface (Total a Receber, Total a Pagar e Saldo Geral) foram destacados em *Cards de Resumo* no topo da tela. 

Para atender à heurística de visibilidade do status, utilizei cores semânticas (`text-success` para valores a receber e `text-danger` para dívidas), garantindo que o usuário identifique instantaneamente se está no azul ou no vermelho. A listagem detalhada foi organizada logo abaixo, respeitando o fluxo natural de leitura, com um botão de ação (FAB) posicionado estrategicamente e estilizado para garantir *affordance*.

### Dificuldade Técnica
**Qual foi o maior desafio ao componentizar o GrupoCard?**
O maior desafio ao componentizar o `GrupoCard` foi entender e configurar corretamente o escopo e o fluxo de dados entre a página principal (`Dashboard.razor`) e o componente filho (`GrupoCard.razor`). 

A passagem do objeto de dados exigiu o uso do atributo `[Parameter]`, mas a principal barreira técnica foi o erro de referência de renderização (falta da diretiva `@using` apontando para o namespace correto do componente). O Blazor não conseguia encontrar o componente até que o namespace fosse explicitamente declarado no `_Imports.razor` ou na própria página. Após superar esse detalhe de configuração, o encapsulamento das regras de UI tornou a manutenção do código consideravelmente mais simples.

## 🚀 Desafio Extra Implementado
Foi adicionado um campo de busca na interface (`<input type="text">`) que filtra a lista de grupos dinamicamente. A funcionalidade foi construída utilizando o recurso de *two-way data binding* do Blazor através do `@bind-value:event="oninput"`. Isso permite que a lista de grupos renderizada na tela seja atualizada em tempo real conforme o usuário digita o nome ou a categoria desejada.

---

## 👨‍💻 Autores
* **Icaro Ferreira de Oliveira**
* **Kaio Robertt Moreira Abreu**
