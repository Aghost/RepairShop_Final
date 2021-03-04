var app = new Vue({
    el: '#app',
    data: {
        products: [],
        selectedProduct: null,
        newStock: {
            productId: 0,
            description: "Size",
            quantity: 10
        }
    },
    mounted() {
        this.getStock();
    },
    methods: {
        getStock(id) {
            this.loading = true;
            axios.get('/Admin/stocks/')
                .then(res => {
                    console.log(res);
                    this.products = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        updateStock() {

        },
        addStock() {
            this.loading = true;
            axios.post('/Admin/stocks/', this.newStock)
                .then(res => {
                    console.log(res);
                    this.products.addStock.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        selectProduct(product) {
            this.selectedProduct = product;
            this.newStock.productId = product.id;
        }
    }
})