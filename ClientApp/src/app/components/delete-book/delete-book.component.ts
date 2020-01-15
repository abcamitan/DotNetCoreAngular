import { Component, OnInit } from '@angular/core';
import { BookService } from 'src/app/services/book.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-delete-book',
  templateUrl: './delete-book.component.html',
  styleUrls: ['./delete-book.component.css']
})
export class DeleteBookComponent implements OnInit {

  book: Book;

  constructor(private service: BookService,
    private route: ActivatedRoute,
    private router: Router
    ) { }

  ngOnInit() {
    this.service.showBook(this.route.snapshot.params.id).subscribe(data =>{
      this.book = data;
    });
  }

  deleteBook(id: number){
    this.service.deleteBook(id).subscribe(data =>{
      this.router.navigate(['/books']);
    });
  }
}
