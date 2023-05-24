db.books.updateMany(
   { "publisher_id": 201 },
   { $set: { "published_date": ISODate("2010-10-24") } }
)
