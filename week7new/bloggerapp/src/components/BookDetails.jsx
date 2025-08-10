import React from 'react';

const books = [
  { id: 1, title: 'Clean Code', author: 'Robert C. Martin' },
  { id: 2, title: 'The Pragmatic Programmer', author: 'Andy Hunt' },
  { id: 3, title: 'You Don’t Know JS', author: 'Kyle Simpson' },
];

function BookDetails() {
  return (
    <div>
      <h2>📘 Book Details</h2>
      <ul>
        {books.map(book => (
          <li key={book.id}>
            {book.title} — {book.author}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default BookDetails;
