Feature: GerenciarProjeto

Background: 
		Given acesso o sistema Mantis
		And efetuo login com usuario 'administrator' e 'administrator'
		And acesso o menu de Gerenciar Projeto

Scenario: Editar status para Release
Given abro grid projeto Teste
And seleciono combo estado igual a 'release'
When seleciono atualizar projeto
Then o estado '30' e gravado para o projeto 'Teste'

Scenario: Editar status para Estavel
Given abro grid projeto Teste
And seleciono combo estado igual a 'estável'
When seleciono atualizar projeto
Then o estado '50' e gravado para o projeto 'Teste'