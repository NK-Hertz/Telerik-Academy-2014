(function () {
    var books = [
        new Book('Idiot', 'Fyodor Dostoevsky'),
        new Book('List', 'Schindler'),
        new Book('Nineteen Eighty-Four', 'George Orwell'),
        new Book('The Old Man and the Sea', 'Ernest Hemingway'),
        new Book('White Nights', 'Fyodor Dostoevsky'),
        new Book('Uncle`s Dream', 'Fyodor Dostoevsky'),
        new Book('A Clergyman`s Daughter', 'George Orwell'),
    ];
    
    // author : book count
    var authors = [{
        name: 'Schindler',
        bookCount: 0
    }];

    _.each(books, function (book) {
        var authorExists = _.find(authors, function (author) {
            return author.name === book._author;
        });

        if (!authorExists) {
            authors.push({
                name: book._author,
                bookCount: 1
            });
        }
        else {
            _.find(authors, function (author) {
                if (author.name === book._author) {
                    author.bookCount++;
                }
            });
        }
    })

    var mostPopularAuthor = _.max(authors, function (author) {
        return author.bookCount;
    });

    console.log('Most popular author is ' + mostPopularAuthor.name + ', with ' +
            mostPopularAuthor.bookCount + ' books.');

    // uncomment to se all authors and their book count
    //console.log(authors);
}());