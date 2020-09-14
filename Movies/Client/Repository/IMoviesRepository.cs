using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Repository
{
    public interface IMoviesRepository
    {
        Task<int> CreateMovie(Movie movie);

        Task<Movie> GetMovieDetails(int Id);

        //Task DeleteMovie(int Id);
        //Task<DetailsMovieDTO> GetDetailsMovieDTO(int id);
        //Task<IndexPageDTO> GetIndexPageDTO();
        //Task<MovieUpdateDTO> GetMovieForUpdate(int id);
        //Task<PaginatedResponse<List<Movie>>> GetMoviesFiltered(FilterMoviesDTO filterMoviesDTO);
        //Task UpdateMovie(Movie movie);
    }
}