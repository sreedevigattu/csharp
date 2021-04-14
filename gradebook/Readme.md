docker run -v ~/code/csharp:/home/csharp -it mcr.microsoft.com/dotnet/sdk:3.1 bash

cd /home/csharp/gradebook/src/GradeBook
dotnet run
