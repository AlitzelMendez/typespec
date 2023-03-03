[JS Api](../index.md) / BearerAuth

# Interface: BearerAuth

Bearer authentication (also called token authentication) is an HTTP authentication scheme that involves security tokens called bearer tokens.
The name “Bearer authentication” can be understood as “give access to the bearer of this token.” The bearer token is a cryptic string, usually generated by the server in response to a login request.
The client must send this token in the Authorization header when making requests to protected resources:
```
  Authorization: Bearer <token>
```

## Hierarchy

- [`HttpAuthBase`](HttpAuthBase.md)

  ↳ **`BearerAuth`**

## Table of contents

### Properties

- [description](BearerAuth.md#description)
- [id](BearerAuth.md#id)
- [scheme](BearerAuth.md#scheme)
- [type](BearerAuth.md#type)

## Properties

### description

• `Optional` **description**: `string`

Optional description.

#### Inherited from

[HttpAuthBase](HttpAuthBase.md).[description](HttpAuthBase.md#description)

___

### id

• **id**: `string`

Id of the authentication scheme.

#### Inherited from

[HttpAuthBase](HttpAuthBase.md).[id](HttpAuthBase.md#id)

___

### scheme

• **scheme**: ``"bearer"``

___

### type

• **type**: ``"http"``