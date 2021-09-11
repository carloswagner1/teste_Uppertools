# Cadastro de Empresas Uppertools

# Plataforma integrada

Exercício feito com único propósito de ingresso no processo de seleção para oportunidade de desenvolvimento na Uppertools Tecnologia da Informação


# Justificativas

Eu utilizei a plataforma do Visual Studio 2019 estruturar a solução, optando por uma solução de frontend baseada no Windows Forms Application, para proporcionar uma interface mais amigável para a entrada e saída de dados. Atribui algumas classes no projeto que, no meu ponto de vista, fazem sentido tanto na construção como na manutenção do código.

A solução de banco de dados escolhida foi o MySQL, muito embora o SQL Server Express também sejam um ótimo SGBD.

Também foram adicionados packages para possibilitar a integração com o banco de dados e com o webservice da Receita Federal.

## Arquitetura

Conforme já mencionado, foram criadas classes para que os atributos e os métodos utilizados no código possam ser visualizados de forma mais organizada e intuitiva, facilitando a programação e manutenção da solução.

Além disto, tal disposição possibilitou estruturar as interações com o banco de dados e com o webservice solicitados no teste.

Foi criado, também, uma classe para o tratamento da validação dos CNPJ's inseridos.

## Tecnologias

As tecnologias envolvidas na solução são C# .NET Framework , tendo Windows Form Application como base da interface. O banco de dados utilizado foi o MySQL. 

Além, disto, para a busca dos dados das empresas pelo CNPL, foi utilizado o JSONpara troca de informações com o WebService da Receita Federal disponível em https://www.receitaws.com.br/v1/cnpj/

## Dificuldades gerais

Posso citar como dificuldade a integração do C# com o MySQL na hora da manipulação dos dados, em especial em relação à atividade de busca e exibição das informações solicitada em dos exercícios. embora tenha toda a estrutura do código de pesquisa por CNPJ e Nome, esta parte da solução não está funcional.

Outra dificuldade foi fazer a integração do o API da Receita, não porque seja algo complicado, mas por nunca ter feito este tipo de programação. Demandou muita pesquisa, mas era a base para a solução funcionar minimamente.

## Conclusão

Embora o projeto, teoricamente, seja algo simples, devido a falta de vivência com este tipo de aplicação, foi necessário estudos e pesquisas para entregar a solução. Serviu não só para o conhecimento, como também como estímulo para buscar me aperfeiçoar no C#  e em todas as interações possíveis que esta linguagem pode nos proporcionar, tais como o Banco de Dados e API's.

