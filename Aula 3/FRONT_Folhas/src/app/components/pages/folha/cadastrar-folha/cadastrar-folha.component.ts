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

  constructor(
    private http : HttpClient, 
    private router : Router, 
    private route: ActivatedRoute) {} 

  ngOnInit(): void {
  }

  cadastrar(): void {
    let dataConvertida = new Date(this.data)
    console.log(dataConvertida.getMonth(), dataConvertida.getFullYear);

    let folha: Folha = {
      quantidadeHoras: this.quantidadeHoras,
      valorHora: this.valorHora,
      ano: 2021,
      mes: 11,
      funcionarioId: 15
    };
    
    //Configurando a requisição para a API
    this.http.post<Folha>("https://localhost:5001/api/folhas/cadastrar", 
    folha)
    .subscribe({
      next : (funcionario) => {
        this.router.navigate(["pages/folha/listar"])
      },
    });
  }
}
