# Event Managment API

Тестовое задание.

## Run Locally

Clone the project

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



