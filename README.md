# Project ví dụ cho asp.NET core mvc

project có sử dụng thệm các framework và library: Entity Framework core and graphql (UI: graphiql) connect to sqlServer

## Cài đặt

edit file appsetting.json

```bash
"ConnectionStrings": {
    "DataContext": "<your connectionstrings>"
  }
```

## Usage

run project:

#### link: 
[https://localhost:<yourport>/graphiql](https://localhost:<yourport>/graphiql)


#### Nhập thử:
```
query{
  products{
    id
    name
    detail
    category{
      name
    }
  }
}
```
#### Đọc thêm docs trong /graphiql để biết thêm
#### Bạn có thể cài extension trên trình duyệt hoặc sử dụng postman để test rest API
## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[Trường](https://github.com/truongginjs/)
