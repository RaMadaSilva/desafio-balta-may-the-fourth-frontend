using AutoMapper;
using MyTheFourth.Frontend.Constants;
using MyTheFourth.Frontend.DevsResistenceContext.Models;
using MyTheFourth.Frontend.Extensions;
using MyTheFourth.Frontend.GalactImpareContext.Constants;
using MyTheFourth.Frontend.Models;
using MyTheFourth.Frontend.Services.Interfaces;

namespace MyTheFourth.Frontend.GalactImpareContext.Services;

public class GalactImpareMyTheFourthHttpService :
IMyTheFourthService
{
    private readonly HttpClient _client;
    private readonly IMapper _mapper;

    public GalactImpareMyTheFourthHttpService(HttpClient client, IMapper mapper)
    {
        _client = client;
        _mapper = mapper;
    }

    public string ServiceId => BackendServicesIdentifiers.GalactImpare;

    public async Task<Character?> GetCharacterAsync(string characterId)
    {
        throw new NotImplementedException();
    }

    public async Task<Movie?> GetMovieAsync(string movieId)
    {
        var response = await _client.GetAsync($"{GalaticEmpireHttpServiceEndpoints.MoviesEndpoint}/{movieId}");

        var result = await response.GetContentData<MovieDataModel>();

        return result is not null ? _mapper.Map<Movie>(result) : default!;
    }

    public async Task<Planet?> GetPlanetAsync(string planetId)
    {
        throw new NotImplementedException();
    }

    public async Task<Starship?> GetStarshipAsync(string starshipId)
    {
        throw new NotImplementedException();
    }

    public Task<Vehicle?> GetVehicleAsync(string vehicleId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Character>> ListCharactersAsync(int? page = null, int? pageSize = null)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Movie>> ListMoviesAsync(int? page = null, int? pageSize = null)
    {
        try
        {

            var response = await _client.GetAsync($"{GalaticEmpireHttpServiceEndpoints.MoviesEndpoint}?pageNumber={page ?? 1}&pageSize={pageSize ?? 10}");

            var result = await response.GetContentData<MovieListResponse>();

            return result?.Results?.Any() is true ? _mapper.Map<IEnumerable<Movie>>(result.Results) : Enumerable.Empty<Movie>();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
        return Enumerable.Empty<Movie>();
    }

    public async Task<IEnumerable<Planet>> ListPlanetsAsync(int? page = null, int? pageSize = null)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Starship>> ListStarshipsAsync(int? page = null, int? pageSize = null)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Vehicle>> ListVehiclesAsync(int? page = null, int? pageSize = null)
    {
        throw new NotImplementedException();
    }
}
