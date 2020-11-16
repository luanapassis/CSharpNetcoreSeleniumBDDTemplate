Feature: GerenciarUsuario

Background: 
		Given acesso o sistema Mantis
		And efetuo login com usuario 'administrator' e 'administrator'
		And acesso o menu de Gerenciar Usuario


Scenario: Trocar Perfil Usuario Administrador
Given pesquiso usuario 'usuario1'
And clico no primeiro item do grid
When seleciono nivel Usuario 'administrador' e gravo a operacao
Then o nivel de acesso '90' e gravado para o usuario 'usuario1'

Scenario: Trocar Perfil Usuario Gerente
Given pesquiso usuario 'usuario1'
And clico no primeiro item do grid
When seleciono nivel Usuario 'gerente' e gravo a operacao
Then o nivel de acesso '70' e gravado para o usuario 'usuario1'

Scenario: Trocar Perfil Usuario Desenvolvedor
Given pesquiso usuario 'usuario1'
And clico no primeiro item do grid
When seleciono nivel Usuario 'desenvolvedor' e gravo a operacao
Then o nivel de acesso '55' e gravado para o usuario 'usuario1'
