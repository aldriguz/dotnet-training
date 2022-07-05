# Instructions
Once you have all the code, run this commands. But make sure your connection string is there even if the Db is not created yet.

```
# check ef cli tool
dotnet ef 

dotnet ef dbcontext list
dotnet ef dbcontext script
dotnet ef dbcontext script > script.sql
```

This last command will create a file with the script for your schema. Create the database and run the script.

# Login
Once you have created your database and have runned the script, go to `/identity/account/login` to proceed with the login.
Note: At this point we have created a `_LoginPartial.cshtml` that is required.