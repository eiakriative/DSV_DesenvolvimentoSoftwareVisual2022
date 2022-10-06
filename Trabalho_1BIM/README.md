# 💡 Trabalho de Desenvolvimento de Software Visual

<br />

# TrabalhoFilmesDB

## Sobre

<table>
<tr>
<td>

Repositorio totalmente voltado para armazenamento do codigo da aplicação para o trabalho da disciplina de Desenvolvimento de software, na qual serve como uma base de dados de filmes e atores e suas informações.

</td>
</tr>
</table>


<br />

## 👨🏻‍🏫 Professor

<table>
<tr>
<td>

### Diogo Steinke Deconto

</td>
</tr>
</table>

<br />

## 🚀 Alunos envolvidos

<table>
<tr>
<td>

### André([@itsandrekanas](https://github.com/itsandrekanas))
### Amanda([@amandagaabs](https://github.com/amandagaabs))
### Daniel([@Daniel-Diniz](https://github.com/Daniel-Diniz))
### Gustavo([@gustavosoaresreis](https://github.com/gustavosoaresreis))

</td>
</tr>
</table>


## Comandos git

<table>
<tr>
<td>

Link: https://github.com/itsandrekanas/gitcomandos/blob/main/README.md

</td>
</tr>
</table>

## Regras para funcionar o projeto

<table>
<tr>
<td>

 ```sh
cd .\FilmesDB\
```

```sh
dotnet restore
```

```sh
dotnet run ou dotnet watch run
```

### Não esqueça da migracao

```sh
dotnet ef migrations add NomeMigracao
```

```sh
dotnet ef database update
```

 </td>
</tr>
</table>

<details open="open"> 
 
<table>
<tr>
<td>

 ### Caso não rode o projeto

```sh
dotnet tool install --global dotnet-ef --version 5.0.17
```

obs:  Ao baixar o EntiyFramework as vezes é necessário abrir e reabrir o vscode.

```sh
dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 5.0.17
```

```sh
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 5.0.17
```

```sh
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.17
```


</td>
</tr>
</table>
</details>

