import React                from 'react';
import { ClickableProps }   from '../../entity';

export const Switchable = (props : ClickableProps) => 
    <button className={"button-block alt text-green " + props.cssClass}>
        <span>{ props.title }</span>
    </button>;
