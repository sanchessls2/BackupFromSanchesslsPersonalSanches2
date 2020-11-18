let product = (productId = 0, categoryId = 0, productName,productDescription,productStock,productPrice) => {
    this.ProductId = productId;
    this.CategoryId = categoryId;
    this.ProductName = productName;
    this.ProductDescription = productDescription;
    this.ProductStock = productStock;
    this.ProductPrice = productPrice;
}

module.exports = product;