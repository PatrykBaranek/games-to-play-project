# Games To Play Project!

Strona ma za zadanie tworzyć listę aktualnie granych gier, którą tworzy użytkownik.

# Instrukcja

## Pierwsze czynności aby włączyć projekt

### 1. Stwórz Bazę Danych w SQLServer o nazwie "GamesToPlay"

### 2. W pliku "appsetting.json" zmień Data Source na swój

"ConnectionStrings": {
"Application": "Data Source={do zmiany};Initial Catalog=GamesToPlay;Integrated Security=True"
},

### 3. W katalogu projektu użyj komendy dotnet-ef aby wprowadzić migracje do bazy danych

dotnet-ef database update

### 4. Uruchom projekt za pomocą komendy "dotnet run"
