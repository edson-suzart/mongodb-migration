**O projeto consiste na configuração de execução de migrations para o mongodb.**

## Tecnologias e conceitos utilizados:

 * .net core 6.0
 * factory pattern
 * docker :whale:

:warning:**Obs:** *Para que a migration seja executada, depende da criação do container local do mongodb.* :warning:

## Qual a vantagem de ter o migrations do mongo?
Não precisamos nos preocupar com criação de indexes, mesmo o mongodb criando nossa base e nossas collections em tempo de execução, os indexes não são criados.

## Como configurar a imagem docker?
1. Instalar o docker `https://docs.docker.com/desktop/install/windows-install/`
2. Rodar o comando `docker pull mongo` para criar a imagem
3. Executar o comando `docker run -p 27017:27017 --name container_name mongo` para configurar local
4. Rodar o projeto para criar as collections/indexes



