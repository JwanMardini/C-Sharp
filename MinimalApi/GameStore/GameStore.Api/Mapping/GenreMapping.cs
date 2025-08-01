using System;
using GameStore.Api.Entities;
using GameStore.Api.Dtos;

namespace GameStore.Api.Mapping;


public static class GenreMapping
{
    public static GenreDto ToDto(this Genre genre)
    {

        return new GenreDto(genre.Id, genre.Name);
    }

}
