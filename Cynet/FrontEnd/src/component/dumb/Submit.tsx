import React                from 'react';
import { ClickableProps }   from '../../entity';

export const Submit = (props : ClickableProps) => 
    <input type="submit" value={ props.title } className="btn black d-sm-block d-md-block d-lg-block" />;
