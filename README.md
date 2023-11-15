# DocsBrasil
DocsBrasil é uma biblioteca .Net para validar e gerar alguns documentos brasileiros

## Documentos Suportados
- CPF
- CNPJ
- Renavam
- Placa

## Instalação

```
dotnet add package DocsBrasil
```

## Validando Documentos
Importe o seguinte namespace

```C#
using DocsBrasil.Extensions;
```

Para validar o documento, basta ter o valor em uma variável do tipo ``string`` e em seguida chamar o método de validação correspondente ao documento.
O método retornará um valor do tipo ``bool``.

#### Exemplo

```C#
string cpf = "01234567890";
if(cpf.IsCpf()){
    // CPF válido
}
```

## Gerando Documentos
Importe o seguinte namespace

```C#
using DocsBrasil.Fakes;
```

Para gerar o documento, chame a classe ``Gerador`` e posteriormete a função do documento que deseja gerar.

#### Exemplos

Único documento
```C#
string cpf = Gerador.Cpf();
```

Array de documento
```C#
string[] cpfs = Gerador.Cpfs(100);
```

## Formatando Documentos
Importe o seguinte namespace

```C#
using DocsBrasil.Extensions;
```

Para formatar o documento, basta ter o valor em uma variável do tipo ``string`` e em seguida chamar o método de formatação correspondente ao documento.
O método retornará um valor do tipo ``string``.

#### Exemplo

```C#
string cpf = "01234567890";
Console.WriteLine(cpf.FormatCpf());
// output: 012.345.678-90
```