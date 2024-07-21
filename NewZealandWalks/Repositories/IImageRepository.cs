using NewZealandWalksAPI.Models.Domain;

namespace NewZealandWalksAPI.Repositories
{
	public interface IImageRepository
	{
		Task<Image> Upload(Image image);
	}
}
