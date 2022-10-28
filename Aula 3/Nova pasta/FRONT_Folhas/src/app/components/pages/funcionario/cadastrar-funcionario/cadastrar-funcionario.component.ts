import { Funcionario } from './../../../../models/Funcionario';
import { Component, OnInit } from "@angular/core";
import { HttpClient } from '@angular/common/http';

@Component({
  selector: "app-cadastrar-funcionario",
  templateUrl: "./cadastrar-funcionario.component.html",
  styleUrls: ["./cadastrar-funcionario.component.css"],
})
export class CadastrarFuncionarioComponent implements OnInit {
  nome!: string;
  cpf!: string;

  constructor(private http : HttpClient) {} 

  ngOnInit(): void {}

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
    this.http.post<Funcionario>("https://localhost:5001/api/funcionario/cadastrar", funcionario)
    //executar a requisição
    .subscribe({
      next : (funcionario) => {
        //Executamos o que for necessario quando a requisição for bem sucedida
        console.log("Gravamos um funcionario", funcionario);
      }
    });
  }
}
