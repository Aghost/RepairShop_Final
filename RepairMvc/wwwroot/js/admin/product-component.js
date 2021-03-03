Vue.component('product-manager', {
    template:`<div>
        <div v-if="!editing">
            <button class="button" @click="newProduct">Add New Product</button>
            <table class="table">
                <tr>
                    <th>productId</th>
                    <th>name</th>
                    <th>partType</th>
                    <th>price</th>
                    <th></th>
                </tr>
                <tr v-for="(product, index) in products">
                    <td>{{product.productId}}</td>
                    <td>{{product.name}}</td>
                    <td>{{product.partType}}</td>
                    <td>{{product.price}}</td>
                    <td><button v-on:click="editProduct(product, index)">Edit</button></td>
                    <td><button v-on:click="deleteProduct(product.productId)">Remove</button></td>
                </tr>
            </table>
        </div>

        <div v-else>
            <div class="field">
                <label class="label">Product Name</label>
                <div class="control">
                    <input class="input" v-model="productModel.name" />
                </div>
            </div>

            <div class="field">
                <div class="control">
                    <label class="label">Product PartType</label>
                    <input class="input" v-model="productModel.partType" />
                </div>
            </div>

            <div class="field">
                <div class="control">
                    <label class="label">Product Description</label>
                    <input class="input" v-model="productModel.description" />
                </div>
            </div>

            <div class="field">
                <div class="control">
                    <label class="label">Product Price</label>
                    <input class="input" v-model="productModel.price" />
                </div>
            </div>

            <button class="button is-success" v-on:click="createProduct" v-if="!productModel.productId">Create Product</button>
            <button class="button is-warning" v-on:click="updateProduct" v-else>Update Product</button>
            <button class="button is-warning" v-on:click="cancel">Cancel</button>
        </div>
    </div>`,
    data() {
        return {
            loading: false,
            editing: false,
            objectIndex: 0,
            productModel: {
                productId: 0,
                name: "Product Name",
                partType: "",
                description: "Product Description",
                price: 1.99,
            },
            products: []
        }
    },
    mounted() {
        this.getProducts();
    },
    methods: {
        getProduct(id) {
            this.loading = true;
            axios.get('/Admin/product/' + id)
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
        getProducts() {
            this.loading = true;
            axios.get('/Admin/products')
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
        createProduct() {
            this.loading = true;
            axios.post('/Admin/products', this.productModel)
                .then(res => {
                    console.log(res.data);
                    this.products.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        updateProduct() {
            this.loading = true;
            axios.put('/Admin/products', this.productModel)
                .then(res => {
                    console.log(res.data);
                    this.products.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        deleteProduct(id, index) {
            this.loading = true;
            axios.delete('/Admin/products/' + id)
                .then(res => {
                    console.log(res);
                    this.products.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newProduct() {
            this.editing = true;
            this.productModel.productId = 0;
        },
        editProduct(product, index) {
            this.editing = true;
            this.objectIndex = index;
            this.productModel = {
                productId: product.productId,
                name: product.name,
                partType: product.partType,
                description: product.description,
                price: product.price,
            };
        },
        cancel() {
            this.editing = false;
        }
    },
    computed: {
    }
})