# Simple Web API

A minimal ASP.NET Core Web API project built for learning and practice.
The project contains **3 controllers**, each exposing basic REST endpoints.

---

## Tech Stack
- ASP.NET Core Web API
- C#
- Swagger (OpenAPI)

---

## Controllers & Endpoints

### Users API
Base route: `/api/users`

| Method | Endpoint | Description |
|------|--------|------------|
| GET | `/api/users` | Get all users |
| GET | `/api/users/{id}` | Get user by ID |
| POST | `/api/users` | Create a new user |
| DELETE | `/api/users/{id}` | Delete a user |

---

### Products API
Base route: `/api/products`

| Method | Endpoint | Description |
|------|--------|------------|
| GET | `/api/products` | Get all products |
| GET | `/api/products/{id}` | Get product by ID |
| POST | `/api/products` | Add a product |
| DELETE | `/api/products/{id}` | Delete a product |

---

### Orders API
Base route: `/api/orders`

| Method | Endpoint | Description |
|------|--------|------------|
| GET | `/api/orders` | Get all orders |
| GET | `/api/orders/{id}` | Get order by ID |
| POST | `/api/orders` | Create an order |
| DELETE | `/api/orders/{id}` | Delete an order |

---

## How to Run
```bash
dotnet run
```

Open Swagger:
```
http://localhost:5290/swagger
```
