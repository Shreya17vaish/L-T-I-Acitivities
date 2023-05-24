db.publisher.updateOne(
  { _id: 203 },
  {$rename:
  { "pub_name": "UniversityPress", "country": "US"  }},
  { upsert: true }
)
