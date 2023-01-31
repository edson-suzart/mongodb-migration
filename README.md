**O projeto consiste na configuração de execução para migrations de mongodb.**

## Tecnologias e conceitos utilizados:

 * .net core 6.0
 * factory pattern
 * docker :whale:

:warning:**Obs:** *Para que a migration seja executada, depende da criação do container local do mongodb.* :warning:

## Como configurar a imagem docker?
1. Instalar o docker https://docs.docker.com/desktop/install/windows-install/
2. Rodar o comando docker pull mongo para criar a imagem
3. Executar o comando docker run -p 27017:27017 --name container_name mongo para configurar local
4. Rodar o projeto para criar as collections/indexes


