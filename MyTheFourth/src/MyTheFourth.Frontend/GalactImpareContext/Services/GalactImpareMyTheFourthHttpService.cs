using AutoMapper;
using MyTheFourth.Frontend.Constants;
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

    public Task<Character?> GetCharacterAsync(string characterId)
    {
        throw new NotImplementedException();
    }

    public Task<Movie?> GetMovieAsync(string movieId)
    {
        throw new NotImplementedException();
    }

    public Task<Planet?> GetPlanetAsync(string planetId)
    {
        throw new NotImplementedException();
    }

    public Task<Starship?> GetStarshipAsync(string starshipId)
    {
        throw new NotImplementedException();
    }

    public Task<Vehicle?> GetVehicleAsync(string vehicleId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Character>> ListCharactersAsync(int? page = null, int? pageSize = null)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Movie>> ListMoviesAsync(int? page = null, int? pageSize = null)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Planet>> ListPlanetsAsync(int? page = null, int? pageSize = null)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Starship>> ListStarshipsAsync(int? page = null, int? pageSize = null)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Vehicle>> ListVehiclesAsync(int? page = null, int? pageSize = null)
    {
        throw new NotImplementedException();
    }
}
