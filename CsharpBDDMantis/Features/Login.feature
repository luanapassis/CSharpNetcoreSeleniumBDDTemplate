Feature: Login

Scenario Outline: Testar Login Sucesso
Given acesso o sistema Mantis
When efetuo login com usuario '<Usuario>' e '<Senha>'
Then login realizado com sucesso para o '<Usuario>'
Examples:
| Usuario     | Senha  |
| luana.assis | 123456 |
| usuario1    | 123456 |
| usuario2    | 123456 |

Scenario Outline: Testar Login Insucesso
Given acesso o sistema Mantis
When efetuo login com usuario '<Usuario>' e '<Senha>'
Then login incorreto com a mensagem '<Mensagem>'
Examples:
| Usuario       | Senha  | Mensagem																										   |
| usu.incorreto | 123456 | Sua conta pode estar desativada ou bloqueada ou o nome de usuário e a senha que você digitou não estão corretos.|

Scenario Outline: Testar Login Desativado
Given acesso o sistema Mantis
When efetuo login com usuario 'usu.inativo ' e '123456'
Then login incorreto com a mensagem 'Sua conta pode estar desativada ou bloqueada ou o nome de usuário e a senha que você digitou não estão corretos.'
