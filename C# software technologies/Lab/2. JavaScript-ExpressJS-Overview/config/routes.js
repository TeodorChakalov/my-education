const homeController = require('./../controllers/home');

module.exports = (app) => {
    app.get('/asd', homeController.indexGet);
    app.post('/asd', homeController.indexPost);
};

