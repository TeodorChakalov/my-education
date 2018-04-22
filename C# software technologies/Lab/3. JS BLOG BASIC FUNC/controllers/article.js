const Article = require('../models').Article;
const User = require('../models').User;
const CREATELINK = `article/create`;

module.exports = {
    createGet: (req, res) => {
        res.render(CREATELINK);
    },
    createPost: (req, res) => {
        let articleArgs = req.body;

        let errorMsg = '';

        if (!req.isAuthenticated) {
            errorMsg = 'You are not logged!';
        } else if (!articleArgs.title) {
            errorMsg = 'Invalid title!';
        } else if (!articleArgs.content) {
            errorMsg = 'Invalid content!';
        }

        if (errorMsg) {
            res.render(CREATELINK, {error: errorMsg});
            return;
        }
        articleArgs.authorId = req.user.id;

        Article.create(articleArgs).then(article => {
            res.redirect('/');
        }).catch(err => {
            console.log(err.message);
            res.render(CREATELINK, {error: err.message});
        })
    },
    detailsGet: (req, res) => {
        let id = req.params.id;
        Article.findById(id, {
            include: [
                {
                    model: User,
                }
            ]
        }).then(article => {
            res.render('article/details', article.dataValues)
        })
    }
};