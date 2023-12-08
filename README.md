# Project screenshots

- main page list of the movies:

<img src="https://raw.githubusercontent.com/RobertNeat/movie_list/master/main_list_page.png" width="500px" heigth="auto"/>

- add new movie page:

<img src="https://raw.githubusercontent.com/RobertNeat/movie_list/master/add_new_screen.png" width="500px" heigth="auto"/>

- details of the movie from the list:
<img src="https://raw.githubusercontent.com/RobertNeat/movie_list/master/details_screen.png" width="500px" heigth="auto"/>

- edit movie element page:
<img src="https://raw.githubusercontent.com/RobertNeat/movie_list/master/edit_screen.png" width="500px" heigth="auto"/>

-  delete movie element page:
<img src="https://raw.githubusercontent.com/RobertNeat/movie_list/master/delete_screen.png" width="500px" heigth="auto"/>

# Special dependencies:

- .net 6
- added secrets:

To add secrets click on the solution in the files pane then select "Manage User Secrets" (Zarządzaj kluczami tajnymi użytkownika) and paste:

```
{
  "ConnectionStrings": {
    "Default": "Data Source=movies.db"
  }
}
```

- SQLite - project uses relational database and ORM, so intall it besore launching project
