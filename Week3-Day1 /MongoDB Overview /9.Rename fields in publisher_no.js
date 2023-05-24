db.author.update({"_id": 41},
{$rename:{
    "email_id" : "mail", "phoneno" : "mobile"
}})
