# TestWinForms

- Create tables in the database using the following sql statements:

``` sql
CREATE TABLE IF NOT EXISTS public.projects
(
    projects_uid SERIAL PRIMARY KEY,
    project_name character(40) NOT NULL,
    is_accepting_new_visits boolean,
    supported_image_type character(5)
)


CREATE TABLE IF NOT EXISTS public.users
(
    users_uid SERIAL PRIMARY KEY,
    username character(20) NOT NULL,
    password character(20) NOT NULL
)
```


- Create test user in order to login to application:

``` sql
INSERT INTO public.users(username, password)
VALUES ('Admin','password')
```

- Change App.config file connection string section with your PostgreSQL server configuration:

``` xml
<connectionStrings>
		<add name="Test" connectionString="Host=localhost;Username=postgres;Password=superuser;Database=test" providerName="System.Data.SqlClient" />
</connectionStrings>)
```
