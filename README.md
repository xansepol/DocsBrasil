# DocsBrasil
DocsBrasil é uma biblioteca .Net para validar e gerar alguns documentos brasileiros

## Documentos Suportados
- CPF
- CNPJ
- Renavam
- Placa

## Validando Documentos
Importe o seguinte namespace

```C#
using DocsBrasil.Extensions;
```

Para validar o documento, basta ter o valor em uma variável do tipo ``string`` e em seguida chamar o método de validação correspondente ao documento, que o método retornará um valor do tipo ``bool``.

#### Exemplo

```C#
string cpf = "01234567890";
if(cpf.IsCpf())
    // CPF válido
else
    // CPF inválido
```

## Gerando Documentos
Importe o seguinte namespace

```C#
using DocsBrasil.Fakes;
```

Para gerar o documento, chame a classe ``Gerador`` e posteriormete a função do documento que deseja gerar.

#### Exemplo

```C#
string cpf = Gerador.Cpf();
string[] cpfs = Gerador.Cpfs(100);
```