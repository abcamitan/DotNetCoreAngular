import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  _baseURL: string = "api/book/";

  constructor(private http: HttpClient) { }

  getAllBooks(){
    return this.http.get<Book[]>(this._baseURL+"GetBooks");
  }

  addBook(book: Book) {
    return this.http.post(this._baseURL+"AddBook", book);
  }

  updateBook(book: Book){
    return this.http.put<Book>(this._baseURL+"UpdateBook/"+ book.id, book);
  }

  deleteBook(id: number){
    return this.http.delete(this._baseURL+"DeleteBook/"+ id);
  }

  showBook(id: number){
    return this.http.get<Book>(this._baseURL+"SingleBook/"+ id);
  }

}
