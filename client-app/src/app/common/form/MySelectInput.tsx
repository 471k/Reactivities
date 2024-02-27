import { useField } from "formik";
import { Form, Label, Select } from "semantic-ui-react";

interface Props {
    placeholder: string;
    name: string;
    options: any;
    label?: string;
}

export default function MySelectInput(props: Props) {
    //helpers help us to manually set a value and manually set the touched status
    //of our input component
    const [field, meta, helpers] = useField(props.name);
    return (
        <Form.Field error={meta.touched && !!meta.error}>
            <label>{props.label}</label>
            <Select
                clearable
                options={props.options}
                value={field.value || null}
                // "_" is used when the parameter is not going to be used
                onChange={(_, d) => helpers.setValue(d.value)}
                onBlur={() => helpers.setTouched(true)}
                placeholder={ props.placeholder }
            />
            {meta.touched && meta.error
                ? ( <Label basic color='red'>{ meta.error }</Label> )
                : null}
        </Form.Field>
    )    
}