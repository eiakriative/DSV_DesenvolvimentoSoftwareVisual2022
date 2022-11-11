import { Funcionario } from './../../../../models/Funcionario';
import { Component, OnInit } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Console } from 'console';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: "app-cadastrar-funcionario",
  templateUrl: "./cadastrar-funcionario.component.html",
  styleUrls: ["./cadastrar-funcionario.component.css"],
})
export class CadastrarFuncionarioComponent implements OnInit {
  nome!: string;
  cpf!: string;
  mensagem!: string;
  email!: string;
  nascimento!: string;
  Id!: string;
  erro!: string;
  
  constructor(
    private http : HttpClient, 
    private router : Router, 
    private route: ActivatedRoute) {} 

    ngOnInit(): void {
      this.route.params.subscribe((params) => {
        let { id } = params;
        if (id !== undefined) {
          this.http
            .get<Funcionario>(
              `https://localhost:5001/api/funcionario/buscar/${id}`
            )
            .subscribe({
              next: (funcionario) => {
                this.Id = id!;
                this.nome = funcionario.nome;
                this.cpf = funcionario.cpf;
              },
            });
        }
      });
    }

    alterar(): void {
      let funcionario: Funcionario = {
        funcionarioId: Number.parseInt(this.Id),
        nome: this.nome,
        cpf: this.cpf,
        email: "andore@kan.com",
        salario: 950,
        //criadoEm: "2022-01-25",
        nascimento: "1995-01-05",
      };
      //Configuração da requisição
      this.http
        .patch<Funcionario>(
          "https://localhost:5001/api/funcionario/alterar",
          funcionario
        )
        //Execução da requisição
        .subscribe({
          //Aqui executamos algo quando a requisição for bem-sucedida
          next: (funcionario) => {
            this.router.navigate(["pages/funcionario/listar"]);
          },
          // //Aqui executamos algo quando a requisição for mal-sucedida
          // error: (error) => {
          //   if (error.status == 400) {
          //     this.erro = "Erro de validação";
          //   } else if (error.status == 0) {
          //     this.erro = "Está faltando iniciar a sua API!";
          //   }
          // },
        });
    }
 
  cadastrar(): void {
    
    let funcionario: Funcionario = {
      nome: this.nome,
      cpf: this.cpf,
      email: "andore@kan.com",
      salario: 950,
      //criadoEm: "2022-01-25",
      nascimento: "1995-01-05",

    };
    
    //Configurando a requisição para a API
    this.http.post<Funcionario>("https://localhost:5001/api/funcionario/cadastrar", 
    funcionario)
    //executar a requisição
    .subscribe({
      next : (funcionario) => {
        //Executamos o que for necessario quando a requisição for bem sucedida
        // console.log("Gravamos um funcionario", funcionario);
        this.router.navigate(["pages/funcionario/listar"])
      },
      error : (error) => {
        // Executamos o que for necessário quando a requisição for mal sucedida
        if (error.status === 400)
        {
          this.mensagem = "Algum erro de requisição ocorreu!"
        }
        else if (error.status === 0)
        {
          this.mensagem = "API não está rodando!"
        }
      }
    });
  }
}

