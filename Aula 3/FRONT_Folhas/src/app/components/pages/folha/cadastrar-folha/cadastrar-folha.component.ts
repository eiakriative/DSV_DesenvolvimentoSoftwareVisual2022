import { Funcionario } from 'src/app/models/Funcionario';
import { Folha } from './../../../../models/Folha';
import { Router, ActivatedRoute } from '@angular/router';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cadastrar-folha',
  templateUrl: './cadastrar-folha.component.html',
  styleUrls: ['./cadastrar-folha.component.css']
})
export class CadastrarFolhaComponent implements OnInit {
  valorHora!: number;
  quantidadeHoras!: number;
  data!: Date;
  funcionarioId!: number;
  funcionarios!: Funcionario[];

  constructor(
    private http : HttpClient, 
    private router : Router, 
    private route: ActivatedRoute) {} 

    ngOnInit(): void {
      //Configuração da requisição
      this.http
        .get<Funcionario[]>("https://localhost:5001/api/funcionario/listar")
        // Execução da requisição
        .subscribe({
          next: (funcionarios) => {
            // console.table(funcionarios);
            this.funcionarios = funcionarios;
          },
        });
    }

  cadastrar(): void {
    let dataConvertida = new Date(this.data)

    let folha: Folha = {
      quantidadeHoras: this.quantidadeHoras,
      valorHora: this.valorHora,
      ano: dataConvertida.getFullYear(),
      mes: dataConvertida.getMonth(),
      funcionarioId: 15
    };
    
    //Configurando a requisição para a API
    this.http.post<Folha>("https://localhost:5001/api/folha/cadastrar", 
    folha)
    .subscribe({
      next : (funcionario) => {
        this.router.navigate(["pages/folha/listar"])
      },
    });
  }
}
