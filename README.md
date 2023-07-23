# Event Managment API

Тестовое задание.

## Prerequisites

.NET 6.0 SDK or higher
Database provider (SQL Server)

## Run Locally

Clone the project

```bash
  git clone https://github.com/igor-goss/EventManagmentAPI.git
```

Go to the EventManagmentAPI project directory

```bash
  cd EventManagmentAPI/EventManagmentAPI
```

Run the API app

```bash
  dotnet run
```

Go to the IdentityServer project directory

```bash
  cd ..
  cd ..
  cd IS6\quickstart\src\IdentityServer
```
Run the IdentityServer app

```bash
  dotnet run
```

Go to Client project directory
```bash 
  cd ..
  cd ..
  cd IS6\quickstart\src\Client
```
Run the Client app
```bash
  dotnet run
```bash
  git clone https://github.com/igor-goss/EventManagmentAPI.git
```


## API Reference

#### Get all events

```http
  GET /api/Event
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `none` | `string` | Returns a list of all items |

#### Get events

```http
  GET /api/Event/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | Id of item to fetch |

#### Create event

```http
  POST /api/Event/
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `Event`      | `Event` | **Requires autorization** Adding a new event |

#### Edit event

```http
  PUT /api/Event/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `Event`      | `Event` | **Requires autorization** Editing an existing event |

#### Delete event

```http
  DELETE /api/Event/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Requires autorization** Deleting an existing event |



