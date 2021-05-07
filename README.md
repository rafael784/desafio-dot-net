# Criar um site de consulta a API de Filmes #

Criar um site para consultar a API de Filmes e trazer os filmes enviados pelo endpoint.

### **O site deve contemplar** ###

- __Login individual__ (não é necessário implementar lógicas de mudança de senha, recuperação e etc..)
- __Uma lista de filmes populares__. Exemplo de chamada na API: `https://api.themoviedb.org/3/movie/popular?api_key={api_key}`.
    * Paginação na tela de lista.
    * Cada filme deve exibir Nome do filme e Foto do filme.
    * Ao clicar em um item da lista, deve levar ao detalhe do filme.
- __Permitir pesquisar__ filmes de forma assíncrona__. Exemplo de chamada na API: `https://api.themoviedb.org/3/search/movie?api_key={api_key}&query=Jack+Reacher`.
- __Detalhes de um filme__. Exemplo de chamada na API: `https://api.themoviedb.org/3/movie/343611?api_key={api_key}`.
    * O item de detalhe deve exibir Nome, Foto e Descrição do filme.
- __Permitir favoritar filmes__.
- __Listar filmes favoritos__.

### **Essencial** ##
* IDE Utilizada deve ser o Visual Studio Community ou Visual Studio Code
* O projeto deve ser estruturado em camadas (onion architecture)
* O projeto WEB deve ser feito em MVC
* Implementar em .Net Core e C#
* O site deve ser responsivo e diagramado em bootstrap (não utlizar framworks prontos como o materialize, etc...)
* A pesquisa de filmes deve ser feita de forma assíncrona
* A listagem deve conter uma paginação
* caso utilize a biblioteca datatables, a pesquisa de filmes não deve ser realizada utilizando o edittext padrão do componente

### **Desejável** ###

* Bibliotecas de terceiros para reduzir o boilerplate
* Injeção de dependências
* Onion archtecture

### **Sugestões** ###

Nesta seção sugerimos algumas bibliotecas para o uso, mas fique à vontade para escolher outras que não estiverem na lista.

* Automapper
* MediatR
* FluentValidation
* Datatables

### **OBS** ###

Para realizar chamadas a API é necessário se cadastrar no site (https://www.themoviedb.org/documentation/api) e gerar uma chave.
A foto das telas de mockup são só um guia, fique a vontade para usar o padrão de usabilidade da sua escolha.

### **Etapas para submissão** ###

Ao finalizar a implementação, o canditador deverá enviar um pull request para o repositório em questão e formalizar por email que finalizou.

Segue o passo-a-passo:

1. Fazer fork do respositório
2. Implementar seu projeto no fork realizado.
3. Comitar e subir todas as alteraçes para o fork criado por você.
4. Enviar um pull request pelo Github.

O fork deverá ser público para inspeção do código.

### **Observações** ###

Não fazer push para este repositório.
Após o envio do pull request, não serão aceitas novas alterações.
