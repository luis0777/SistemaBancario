# Sistema Bancario

![Texto Alternativo](https://th.bing.com/th/id/OIP.VF9j49EAPmKUUPYBfYNYLQHaEK?rs=1&pid=ImgDetMain)

#### Classe ContaBancaria
Esta classe representa uma conta bancária. Possui as seguintes propriedades e métodos:


Propriedades:

Numero: Armazena o número da conta.

Digito: Armazena o dígito da conta.

Senha: Armazena a senha da conta.

Titular: Armazena o nome do titular da conta.

Saldo: Armazena o saldo atual da conta.


Construtores:

O construtor principal inicializa as propriedades com os valores fornecidos.

Um segundo construtor permite inicializar a conta com um depósito inicial.


Métodos:
Deposito(double quantia): Adiciona a quantia informada ao saldo.

Saque(double quantia): Deduz a quantia informada (mais uma taxa de R$ 5,00) do saldo.

ToString(): Retorna uma representação string da conta, incluindo o número, o titular e o saldo formatado.

#### 2. Classe CriarConta
Esta classe é responsável por criar uma nova conta bancária.


Método:

CriandoConta(): Realiza a coleta de dados do titular, gera um número e dígito da conta aleatórios, solicita a criação de uma senha e retorna uma nova instância de ContaBancaria. O método inclui validações para garantir que o nome do titular e a senha sejam válidos.

#### 3. Classe DadosAtualizados
Esta classe exibe os dados da conta bancária.


Construtor:

Recebe uma instância de ContaBancaria.

Método:

DadosDaConta(): Exibe as informações da conta usando a representação string da classe ContaBancaria.

#### 4. Classe Deposito
Esta classe lida com operações de depósito.


Construtor:

Recebe uma instância de ContaBancaria.


Método:

Depositar(): Solicita a quantia a ser depositada, valida o valor e chama o método de depósito da conta.

#### 5. Classe EscolhaDaOperação
Esta classe permite ao usuário escolher uma operação para realizar na conta bancária.


Construtor:

Recebe uma instância de ContaBancaria.


Método:

TipoDeOperação(): Exibe um menu de operações (dados da conta, depósito, saque ou sair) e executa a operação escolhida. Valida a escolha do usuário e permite a interação com outras classes (como DadosAtualizados, Deposito, e Saque).

#### 6. Classe LoginConta
Esta classe lida com o processo de login do usuário na conta bancária.


Método:

LogadoNaConta(ContaBancaria conta): Solicita ao usuário o número da conta, dígito e senha, validando essas informações. Se o login for bem-sucedido, chama a classe EscolhaDaOperação para que o usuário possa realizar operações na conta.

#### 7. Classe Saque
Esta classe lida com operações de saque.


Construtor:

Recebe uma instância de ContaBancaria.


Método:

Sacar(): Solicita a quantia a ser sacada, valida o valor, e verifica se há saldo suficiente. Se não houver, pergunta ao usuário se ele deseja continuar com um saldo negativo.

#### 8. Classe TelaInicial
Esta classe apresenta o menu inicial do aplicativo.


Método:
Inicio(): Exibe um menu para criar uma nova conta, entrar em uma conta existente ou sair do programa. Dependendo da escolha do usuário, chama as classes CriarConta ou LoginConta para gerenciar a conta.

#### 9. Classe Program
Esta é a classe principal que inicia o aplicativo.


Método:

Main(): Inicializa uma instância de TelaInicial e chama o método Inicio(), que gerencia o fluxo do aplicativo.

#### Resumo📝
O aplicativo simula um sistema bancário básico onde os usuários podem criar contas, fazer depósitos, realizar saques e visualizar os dados da conta. Cada classe desempenha um papel específico, seguindo os princípios de encapsulamento e separação de responsabilidades, facilitando a manutenção e a extensão do código
