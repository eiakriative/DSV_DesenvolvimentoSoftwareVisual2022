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
  id!: string;

  constructor(
    private http : HttpClient, 
    private router : Router, 
    private route: ActivatedRoute) {} 

  ngOnInit(): void {
    this.route.params.subscribe({
      next: (params) => {
        let {id} = params;
        this.id = id;
        // this.nome = "nome"
        // console.log(id);
      } 
    })
  }

  cadastrar(): void {

    let funcionario: Funcionario = {
      nome: this.nome,
      cpf: this.cpf,
      email: "andore@kan.com",
      salario: 950,
      criadoEm: "2022-01-25",
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
