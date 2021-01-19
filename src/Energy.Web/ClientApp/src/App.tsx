import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';

import './custom.css'
import Catalog from './components/Catalog/Catalog';

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/catalog' component={Catalog} />
        {/* <Route path='/catalog/create' component={CatalogItemCreate} /> */}
    </Layout>
);
