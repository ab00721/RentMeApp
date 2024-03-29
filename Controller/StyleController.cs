﻿using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the StyleDAL and the view.
    /// </summary>
    public class StyleController
    {
        private readonly StyleDAL _styleSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleController"/> class.
        /// </summary>
        public StyleController()
        {
            _styleSource = new StyleDAL();
        }

        /// <summary>
        /// Returns a list of all style.
        /// </summary>
        public List<Style> GetAllStyles()
        {
            return _styleSource.GetAllStyles();
        }
    }
}
