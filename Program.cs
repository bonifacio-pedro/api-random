using ApiRandomPasswd;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.UseHttpsRedirection();

app.MapGet("/{charqnt}/a", (int charqnt) => Generator.GenPasswd(charqnt,true));
app.MapGet("/{charqnt}/n", (int charqnt) => Generator.GenPasswd(charqnt, false));
app.MapGet("/{charqnt}/a/s", (int charqnt) => Generator.GenSecurityPasswd(charqnt, true));
app.MapGet("/{charqnt}/n/s", (int charqnt) => Generator.GenSecurityPasswd(charqnt, false));

app.Run();
