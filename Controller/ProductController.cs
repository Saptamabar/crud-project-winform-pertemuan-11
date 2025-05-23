using crud_project_winform.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_project_winform.Controller
{
    public class ProductController
    {
        public static List<ProductModel> GetAllProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM produk";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductModel product = new ProductModel
                            {
                                id_produk = reader.GetInt32(0),
                                nama_produk = reader.GetString(1),
                                harga = reader.GetInt32(2),
                                deskripsi = reader.GetString(3),
                            };
                            products.Add(product);
                        }
                    }
                }
                Database.CloseConnection();
            }
            return products;
        }

        public static void InsertProducts(ProductModel produk)
        {
            string query = $"INSERT INTO produk (nama_produk, harga, deskripsi) VALUES(@nama_produk, @harga, @deskripsi)";
            try
            {
                using (var con = Database.GetConnection())
                {
                    con.Open();
                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nama_produk", produk.nama_produk);
                        cmd.Parameters.AddWithValue("@harga", produk.harga);
                        cmd.Parameters.AddWithValue("@deskripsi", produk.deskripsi);
                        cmd.ExecuteNonQuery();

                    }
                    con.Close();
                }
                Database.CloseConnection();

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                Database.CloseConnection();
                MessageBox.Show("Data berhasil ditambahlan");

            }
        }
    }
}
